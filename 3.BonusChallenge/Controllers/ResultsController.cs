using _3.BonusChallenge_1;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using System.Linq;


public class ResultsController : Controller
{
    private readonly Resource _resource = new Resource();

    public ViewResult SimpleList()
    {
        var model = new ResultsModel();

        model.ResultList = ResourceHelper.Output(_resource.SimpleList).ToList();

        return View(model);
    }

    public ViewResult HarderList()
    {
        var model = new ResultsModel();
        model.ResultList = ResourceHelper.Output(_resource.HarderList).ToList();

        return View(model);
    }
}