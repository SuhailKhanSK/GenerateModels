using GenerateModels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateModels
{
    public class Repository
    {
        public bool SaveWell(Well wellToSave)
        {
            Exception exception = null;
            //for (int i = 0; i < RETRY_COUNT; i++)
            {
                try
                {
                    using (Mx4220Context context = new Mx4220Context())
                    {
                        if (wellToSave != null)
                        {
                            Well existingWell = context.Wells.FirstOrDefault(well => well.Id == wellToSave.Id);
                            if (existingWell != null)
                            {
                                context.Attach(existingWell);
                                context.Entry(existingWell).CurrentValues.SetValues(wellToSave);

                                // Update or Add Run
                                foreach (Run runToSave in wellToSave.Runs)
                                {
                                    Run existingRun = existingWell.Runs.FirstOrDefault(run => run.Id == runToSave.Id);
                                    if (existingRun != null)
                                    {
                                        context.Entry(existingRun).CurrentValues.SetValues(runToSave);

                                        // Update or Add Solution
                                        foreach (Solution solnToSave in runToSave.Solutions)
                                        {
                                            Solution existingSoln = existingRun.Solutions.FirstOrDefault(soln => soln.Id == solnToSave.Id);
                                            if (existingSoln != null)
                                            {
                                                try
                                                {

                                                    context.Entry(existingSoln).CurrentValues.SetValues(solnToSave);
                                                }
                                                catch (Exception ex)
                                                {

                                                    throw;
                                                }
                                            }
                                            else
                                            {
                                                existingRun.Solutions.Add(solnToSave);
                                            }
                                        }

                                        // Delete Removed Solutions
                                        List<Solution> removedSolutions = existingRun.Solutions.Where(e => !runToSave.Solutions.Any(soln => soln.Id == e.Id)).ToList();
                                        foreach (Solution removedSoln in removedSolutions)
                                        {
                                            existingRun.Solutions.Remove(removedSoln);
                                            context.Solutions.Remove(removedSoln);
                                        }

                                        // Update or Add RawSurvey
                                        //foreach (RawSurvey rawSurveyToSave in runToSave.RawSurveys)
                                        //{
                                        //    RawSurvey existingRaw = existingRun.RawSurveys.FirstOrDefault(raw => raw.Id == rawSurveyToSave.Id);
                                        //    if (existingRaw != null)
                                        //    {
                                        //        context.Entry(existingRaw).CurrentValues.SetValues(rawSurveyToSave);

                                        //        // Update or Add CorrectedSurvey
                                        //        if (existingRaw.CorrectedSurvey != null)
                                        //        {
                                        //            context.Entry(existingRaw.CorrectedSurvey).CurrentValues.SetValues(rawSurveyToSave.CorrectedSurvey);
                                        //        }

                                        //        // Update or Add CorrectedSurveyValues
                                        //        foreach (var item in rawSurveyToSave.CorrectedSurvey.Values)
                                        //        {

                                        //        }
                                        //    }
                                        //    else
                                        //    {
                                        //        existingRun.RawSurveys.Add(rawSurveyToSave);
                                        //    }
                                        //}

                                        // Delete Removed RawSurveys
                                        //existingRun.RawSurveys.RemoveAll(e => !runToSave.RawSurveys.Any(s => s.Id == e.Id));

                                    }
                                    else
                                    {
                                        existingWell.Runs.Add(runToSave);
                                    }
                                }

                                // Delete Removed Runs
                                List<Run> removedRuns = existingWell.Runs.Where(e => !wellToSave.Runs.Any(run => run.Id == e.Id)).ToList();
                                foreach (var removedRun in removedRuns)
                                {
                                    existingWell.Runs.Remove(removedRun);
                                    context.Runs.Remove(removedRun);
                                }
                            }
                            else
                            {
                                context.Wells.Add(wellToSave);
                            }

                            int rowsAffected = context.SaveChanges();


                            return rowsAffected > 0;
                        }
                    }

                }
                catch (Exception ex)
                {
                    exception = ex;
                }
            }

            if (exception != null)
            {
                throw exception;
            }
            return false;
        }

    }
}
