using BOL;
using BOL.HelpModel;
using BOL.Models;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BLL
{
   public class LogicReports
    {
        public static List<ProjectReport> CreateProjectReport()
        {
            List<Project> projects = LogicProjects.GetAllProjects();
            List<ProjectReport> projectReports = new List<ProjectReport>();
            foreach (Project project in projects)
            {
                List<User> allWorkers = new List<User>();
                allWorkers = LogicManager.GetWorkersByProjectId(project.ProjectId);
                List<WorkerForProjectReport> workersForProjectReport = new List<WorkerForProjectReport>();
                foreach (User worker in allWorkers)
                {
                    WorkerForProjectReport workerForProjectReport = new WorkerForProjectReport();
                    workerForProjectReport = LogicManager.GetWorkerInfoForProjectReport(project.ProjectId, worker.UserId);
                    workerForProjectReport.UserName = worker.UserName;
                    workersForProjectReport.Add(workerForProjectReport);
                }
                projectReports.Add(new ProjectReport { ProjectInfo = project, ProjectStateByPrecents = LogicProjects.GetProjectState(project.ProjectId), Workers = workersForProjectReport });
            }
            return projectReports;
        }
    }
}
