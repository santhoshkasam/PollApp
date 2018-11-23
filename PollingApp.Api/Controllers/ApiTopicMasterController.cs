using PollingApp.Models;
using PollingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PollingApp.Api.Controllers
{
  public class ApiTopicMasterController : ApiController
  {
    private readonly ITopicMasterRepo _topicMasterRepo;
    public ApiTopicMasterController(ITopicMasterRepo topicMasterRepo)
    {
      _topicMasterRepo = topicMasterRepo;
    }
    // GET: api/ApiTopicMaster
    public IEnumerable<TopicMaster> Get()
    {
      return _topicMasterRepo.GetAll();
    }

    // GET: api/ApiTopicMaster/5
    public TopicMaster Get(int id)
    {
      return _topicMasterRepo.Get(id);
    }

    // POST: api/ApiTopicMaster
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/ApiTopicMaster/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/ApiTopicMaster/5
    public void Delete(int id)
    {
    }
  }
}
