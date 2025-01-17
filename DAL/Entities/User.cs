﻿using System.ComponentModel.DataAnnotations;
using DAL.Enums;

namespace DAL.Entities;

public class User : BaseEntity
{
    [Required] 
    [MaxLength(20)]
    public string Name { get; set; } = null!;
    public UserRole? UserRole { get; set; }
    public TeamColor? Team { get; set; }

    [Required]
    public Guid RoomId { get; set; }
    public Room Room { get; set; } = null!;
}