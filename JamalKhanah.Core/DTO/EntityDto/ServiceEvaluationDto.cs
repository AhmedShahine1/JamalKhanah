﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamalKhanah.Core.DTO.EntityDto;

public class ServiceEvaluationDto
{
    [Required(ErrorMessage = "التقييم مطلوب ")]
    [Display(Name = "التقييم ")]
    [Range(1, 5, ErrorMessage = "التقييم يجب ان يكون بين 1 و 5 ")]
    public int NumberOfStars { get; set; }

    [Required(ErrorMessage = "التعليق مطلوب ")]
    [Display(Name = "التعليق ")]
    [StringLength(500, ErrorMessage = "التعليق يجب ان لا يزيد عن 500 حرف ")]
    public string Comment { get; set; }

    [Required(ErrorMessage = "رقم الخدمة مطلوب ")]
    [Display(Name = "رقم الخدمة ")]
    public int  ServiceId { get; set; }
        
}