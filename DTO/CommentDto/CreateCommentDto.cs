﻿namespace DTO.CommentDto;

public class CreateCommentDto
{
    public Guid IdHotel { get; set; }
    
    public string IdUser { get; set; }
    
    public string Text { get; set; }
    
    public string PositiveText { get; set; }
    
    public string NegativeText { get; set; }
    
    public short ReviewScore { get; set; }
}