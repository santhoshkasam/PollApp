using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingApp.Models
{
  public class TopicMaster
  {
    [Key]
    public int TopicId { get; set; }
    public string TopicCode { get; set; }
    public string TopicName { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedBy { get; set; }
    public int LastModifiedBy { get; set; }
    public DateTime LastModifieddate { get; set; }

  }
}
