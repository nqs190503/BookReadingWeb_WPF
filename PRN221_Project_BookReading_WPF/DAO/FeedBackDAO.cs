using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FeedBackDAO
    {
        private PRN221_ProjectContext _context;
        private static FeedBackDAO _instance = null;
        public static FeedBackDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FeedBackDAO();
                }
                return _instance;
            }
        }
        private FeedBackDAO()
        {
            _context = new PRN221_ProjectContext();
        }
        public List<Report> GetAllFeedBack()
        {
            try
            {
                return _context.Reports
                .Include(x => x.Book)
                .Include(x => x.ProblemNavigation)
                .Include(x => x.User)
                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public void UpdateReplyStatus(int reportId)
        {
            try
            {
                var report1 = _context.Reports.SingleOrDefault(b => b.ReportId == reportId);
                if (report1 != null)
                {
                    report1.ReplyStatus = "Replied";
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Report> GetFeedBackBySearch(string text)
        {
            try
            {
                return _context.Reports
                .Include(x => x.Book)
                .Include(x => x.ProblemNavigation)
                .Include(x => x.User)
                .Where(u =>
                u.User.UserName.ToLower().Contains(text) ||
                u.Book.Title.ToLower().Contains(text) ||
                u.ProblemNavigation.ReportType1.ToLower().Contains(text) ||
                u.Chapter.ToLower().Contains(text))
                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Report> GetFeedBackByReplySatus(string status)
        {
            try
            {
                return _context.Reports
                .Include(x => x.Book)
                .Include(x => x.ProblemNavigation)
                .Include(x => x.User)
                .Where(u => u.ReplyStatus == status).ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<Response> GetAllResponseFeedBack()
        {
            try
            {
                return _context.Responses
                .Include(x => x.Report)
                .Include(x => x.User)
                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public void AddResponseFeedBack(Response response)
        {
            try
            {
                _context.Responses.Add(response);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Response> GetResponseFeedBackBySearch(string text)
        {
            try
            {
                return _context.Responses
                .Include(x => x.User)
                .Include(x => x.Report)
                .Where(u =>
                u.User.UserName.ToLower().Contains(text) ||
                u.Report.Book.Title.ToLower().Contains(text) ||
                u.Report.ProblemNavigation.ReportType1.ToLower().Contains(text) ||
                u.Report.Chapter.ToLower().Contains(text))
                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
