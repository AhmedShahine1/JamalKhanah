﻿using JamalKhanah.BusinessLayer.Interfaces;
using JamalKhanah.Core.DTO;
using JamalKhanah.Core.Helpers;
using JamalKhanah.RepositoryLayer.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JamalKhanah.Controllers.API;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class SlidePhotosController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly BaseResponse _baseResponse ;
    private readonly IAccountService _accountService;

    public SlidePhotosController(IUnitOfWork unitOfWork, IAccountService accountService)
    {
        _accountService = accountService;
        _unitOfWork = unitOfWork;
        _baseResponse = new();
    }

    [HttpGet]
    public async Task<ActionResult<BaseResponse>> Get([FromHeader] string lang)
    {
        var stop = await _accountService.StopAsync();
        if (stop == "true")
        {
            var allSlides = _unitOfWork.SlidePhotos.FindAll(s => s.IsShow == true && s.IsDeleted == false).ToList();
            if (allSlides.Any())
            {
                _baseResponse.Data = allSlides.Select(s => new
                {
                    s.Id,
                    Name = (lang == "ar") ? s.TitleAr : s.TitleEn,
                    Description = (lang == "ar") ? s.DescriptionAr : s.DescriptionEn,
                    s.ImgUrl,

                });

                _baseResponse.ErrorCode = 0;
            }
            else
            {
                _baseResponse.ErrorCode = (int)Errors.NotFound;
                _baseResponse.ErrorMessage = (lang == "ar") ? "لا توجد صور لعرضها " : "There are no slides to display";
            }
        }
        else
        {
            _baseResponse.ErrorCode = (int)Errors.NotFound;
            _baseResponse.ErrorMessage = (lang == "ar") ? "لا توجد صور لعرضها " : "There are no slides to display";
        }
        return Ok(_baseResponse);
    }

}