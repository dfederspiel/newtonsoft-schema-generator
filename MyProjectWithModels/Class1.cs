using System;
using System.Collections.Generic;
using System.Linq.Expressions;


/// <summary>
/// Classes to convert with NewtonSoft JSON Schema Generator
/// </summary>
namespace MyProjectWithModels
{
    public struct MyCustomType1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> MyFancyCollection { get; set; }
    }

    public struct MyCustomType2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public struct MyCustomType3
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public struct MyCustomType4
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public struct MyCustomType5
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public struct MyCustomType6
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public struct MyCustomType7
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ThingOne
    {
        public string FancyString { get; set; }
        public string NumberAsString { get; set; }
        public bool? IsActive { get; set; }
        public bool Deleted { get; set; }
    }

    public class ThingTwo
    {
        public int ThingId { get; set; }
        public ThingOne ThingOne { get; set; }
    }

    public class ThingThree
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NumberAsString { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public static Expression<Func<ThingTwo, ThingThree>> FromRetreaderRetreadShopMappings => someRandomMapping => new ThingThree
        {
            Id = someRandomMapping.ThingId,
            Name = someRandomMapping.ThingOne != null ? someRandomMapping.ThingOne.FancyString : null,
            NumberAsString = someRandomMapping.ThingOne != null ? someRandomMapping.ThingOne.NumberAsString : null,
            IsActive = someRandomMapping.ThingOne != null ? someRandomMapping.ThingOne.IsActive ?? false : false,
            Deleted = someRandomMapping.ThingOne != null ? someRandomMapping.ThingOne.Deleted : false,
        };
    }
}
