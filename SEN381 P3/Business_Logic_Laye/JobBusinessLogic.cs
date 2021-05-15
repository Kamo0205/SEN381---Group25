using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public enum jobType
    {
        callCentre,
        technician
    }

    class JobBusinessLogic
    {
        DBAccess db = new DBAccess();

        public void deleteJob(string id)
        {
            try
            {
                db.DeleteJob(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : deleteJob ERROR:" + e.Message);
                throw;
            }
        }

        public void updateJob(Job job)
        {
            try
            {
                db.UpdateJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : updateJob ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> getJobById(string id)
        {
            try
            {
                DataTable jobData = db.GetJobByID(id);
                List<Job> jobs = new List<Job>();
                if (jobData != null && jobData.IsInitialized)
                {
                    for (int i = 0; i < jobData.Rows.Count; i++)
                    {
                        jobs.Add(new Job(data: jobData, i: i));
                    }
                    return jobs;
                }

                return null;

            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : getJobById ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> getJobByType(jobType type)
        {
            try
            {
                DataTable jobData = new DataTable();
                List<Job> jobs = new List<Job>();
                switch (type)
                {
                    case jobType.callCentre:
                        jobData = db.GetJobByType("CallCentre");
                        break;
                    case jobType.technician:
                        jobData = db.GetJobByType("Technician");
                        break;
                    default:
                        break;
                }
                if (jobData != null && jobData.IsInitialized)
                {
                    for (int i = 0; i < jobData.Rows.Count; i++)
                    {
                        jobs.Add(new Job(data: jobData, i: i));
                    }
                    return jobs;
                }

                return null;

            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : getJobByType ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> getUnassignedJobByType(jobType type)
        {
            try
            {
                DataTable jobData = new DataTable();
                List<Job> jobs = new List<Job>();
                switch (type)
                {
                    case jobType.callCentre:
                        jobData = db.GetJobByType(type:"CallCentre");
                        break;
                    case jobType.technician:
                        jobData = db.GetJobByType(type:"Technician");
                        break;
                    default:
                        break;
                }
                
                if (jobData != null && jobData.IsInitialized)
                {
                    for (int i = 0; i < jobData.Rows.Count; i++)
                    {
                        if (jobData.Rows[i]["JobStatus"].ToString() == "Unassigned" && jobData.Rows[i]["EmpID"] == null)
                        {
                            jobs.Add(new Job(data: jobData, i: i));
                        }
                    }
                    return jobs;
                }

                return null;

            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : getUnassignedJobByType ERROR:" + e.Message);
                throw;
            }
        }

        public void createJob(Job job)
        {
            try
            {
                db.CreateJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : createJob ERROR:" + e.Message);
                throw;
            }
        }
    }
}
