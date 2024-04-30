﻿namespace Discussion.Models.DTOs.Responses;

public class KafkaResponseDto
{
    public PostResponseTo? Response { get; set; }
    public List<PostResponseTo>? ResponseList { get; set; }
    public ErrorResponseDto? Error { get; set; }
}