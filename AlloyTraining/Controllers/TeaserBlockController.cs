using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full}, AvailableWithoutTag = true)]
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewmodel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };

            return PartialView(viewmodel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide })]
    public class TeaserBlockWideController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewModel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };

            return PartialView(viewModel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow })]
    public class TeaserBlockNarrowController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewModel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };

            return PartialView(viewModel);
        }
    }
}
