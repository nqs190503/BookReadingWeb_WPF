using BussinessObject.Models;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public class FeedBackRepository : IFeedBackRespository
    {
        public List<Report> GetAllFeedBack() => FeedBackDAO.Instance.GetAllFeedBack();
        public List<Report> GetFeedBackBySearch(string text) => FeedBackDAO.Instance.GetFeedBackBySearch(text);
        public List<Report> GetFeedBackByReplySatus(string status) => FeedBackDAO.Instance.GetFeedBackByReplySatus(status);
        public List<Response> GetAllResponseFeedBack() => FeedBackDAO.Instance.GetAllResponseFeedBack();

        public List<Response> GetResponseFeedBackBySearch(string text) => FeedBackDAO.Instance.GetResponseFeedBackBySearch(text);
        public void AddResponseFeedBack(Response response) => FeedBackDAO.Instance.AddResponseFeedBack(response);
        public void UpdateReplyStatus(int reportId) => FeedBackDAO.Instance.UpdateReplyStatus(reportId);

        
    }
}
