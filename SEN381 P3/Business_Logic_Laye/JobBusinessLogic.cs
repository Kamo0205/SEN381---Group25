using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    class JobBusinessLogic
    {
        DBAccess db = new DBAccess();

        private List<Job> jobs = new List<Job>();

        void deleteJob(string id)
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

        void updateJob(Job job)
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

        List<Job> getJob(string id)
        {
            try
            {
                DataTable jobData = db.GetJobByID(id);
                if(jobData != null && jobData.IsInitialized)
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
                MessageBox.Show("JobBusinessLogic : getJob ERROR:" + e.Message);
                throw;
            }
        }

        List<Job> getJobByType(string type)
        {
            try
            {
                DataTable jobData = db.GetJobByType(type);
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
                MessageBox.Show("JobBusinessLogic : getJob ERROR:" + e.Message);
                throw;
            }
        }

        void createJob(Job job)
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
