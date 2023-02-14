﻿using LearningResourcesAPI.Domain;

namespace LearningResourcesAPI.Models;

public record GetResourceResponse
{
    public List<GetResourceItem> Items { get; init; } = new();
}

public record GetResourceItem
{
    public string Id { get; init; } = "";
    public string Description { get; init; } = "";
    public LearningItemType Type { get; init; }
    public string Link { get; init; } = "";
}
