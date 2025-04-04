using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public interface IFeedBackRespository
    {
        public List<Report> GetAllFeedBack();
        public List<Report> GetFeedBackBySearch(string text);
        public List<Report> GetFeedBackByReplySatus(string status);
        public List<Response> GetAllResponseFeedBack();
        public List<Response> GetResponseFeedBackBySearch(string text);
        public void AddResponseFeedBack(Response response);
        public void UpdateReplyStatus(int reportId);


    }
}
