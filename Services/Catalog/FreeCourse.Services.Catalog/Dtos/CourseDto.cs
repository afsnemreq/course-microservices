﻿using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }
        public FeatureDto Feature { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
