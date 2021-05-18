using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public enum jobCategory
    {
        hardware,
        software
    }

    public enum jobType
    {
        instalation,
        repair
    }

    public enum jobSearchParamaters
    {
        id,
        contractID,
        status
    }

    public class JobBusinessLogic
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

        public void assignJob(string jobId, string employeeId)
        {
            try
            {
                db.ReassignJob(jobId, employeeId);
            }
            catch (Exception e)
            {
                MessageBox.Show("JobBusinessLogic : assignJob ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> getJobsBySearchParamater(jobSearchParamaters paramater,string query)
        {
            try
            {
                DataTable jobData = new DataTable(); 
                switch (paramater)
                {
                    case jobSearchParamaters.id:
                        jobData = db.GetJobByID(query);
                        break;
                    case jobSearchParamaters.contractID:
                        jobData = db.ListJobsByContractID(query);
                        break;
                    case jobSearchParamaters.status:
                        jobData = db.ListJobsByStatus(query);
                        break;
                    default:
                        break;
                }
                
                List<Job> jobs = new List<Job>();
                if (jobData.Rows.Count > 0)
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
                MessageBox.Show("JobBusinessLogic : getJobsBySearchParamater ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> listJobByCategory(jobCategory category)
        {
            try
            {
                DataTable jobData = new DataTable();
                List<Job> jobs = new List<Job>();
                switch (category)
                {
                    case jobCategory.hardware:
                        jobData = db.ListJobsByCategory("Hardware");
                        break;
                    case jobCategory.software:
                        jobData = db.ListJobsByCategory("Software");
                        break;
                    default:
                        break;
                }
                if (jobData.Rows.Count > 0)
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
                MessageBox.Show("JobBusinessLogic : getJobByCategory ERROR:" + e.Message);
                throw;
            }
        }

        public List<Job> listJobByType(jobType type)
        {
            try
            {
                DataTable jobData = new DataTable();
                List<Job> jobs = new List<Job>();
                switch (type)
                {
                    case jobType.instalation:
                        jobData = db.ListJobsByType("Instalation");
                        break;
                    case jobType.repair:
                        jobData = db.ListJobsByType("Repair");
                        break;
                    default:
                        break;
                }
                if (jobData.Rows.Count > 0)
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

        public List<Job> listJobsByCategoryAndType(jobCategory category, jobType type)
        {
            try
            {
                DataTable jobData = new DataTable();
                List<Job> jobs = new List<Job>();
                switch (category)
                {
                    case jobCategory.hardware:
                        jobs = listJobByCategory(jobCategory.hardware);
                        break;
                    case jobCategory.software:
                        jobs = listJobByCategory(jobCategory.software);
                        break;
                    default:
                        break;
                }
                switch (type)
                {
                    case jobType.instalation:
                        jobs = jobs.Except(listJobByType(jobType.repair)).ToList();
                        break;
                    case jobType.repair:
                        jobs = jobs.Except(listJobByType(jobType.instalation)).ToList();
                        break;
                    default:
                        break;
                }
                if(jobs.Count > 0)
                {
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

        public List<Job> listUnassignedJobByCategoryAndType(jobCategory category, jobType type)
        {
            try
            {
                List<Job> jobs = new List<Job>();
                List<Job> unassignedJobs = new List<Job>();
                jobs = listJobsByCategoryAndType(category, type);

                foreach (Job job in jobs)
                {
                    if (job.JobStatus == "Unassigned" && job.EmployeeID == null)
                    {
                        unassignedJobs.Add(job);
                    }
                }

                if (unassignedJobs.Count > 0)
                {
                    return unassignedJobs;
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
