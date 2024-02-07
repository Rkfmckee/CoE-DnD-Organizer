using System.Diagnostics;
using coe.dnd.dal.Models;

namespace coe.dnd.api.ViewModels.Campaigns;

public class CampaignViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Theme { get; set; }
    public string Details { get; set; }
    public string Writer { get; set; }
}