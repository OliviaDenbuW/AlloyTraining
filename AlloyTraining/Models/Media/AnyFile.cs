using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File",
                 GUID = "a970210e-0805-4d68-8e42-80a0a9223c37",
                 Description = "Use this to upload any type of file")]
    public class AnyFile : MediaData
    {
        
    }
}