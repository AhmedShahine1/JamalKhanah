using JamalKhanah.BusinessLayer.Interfaces;
using JamalKhanah.Core.Helpers;
using JamalKhanah.Core.ModelView.AuthViewModel.UpdateData;
using JamalKhanah.RepositoryLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JamalKhanah.Controllers.MVC
{
    public class ServiceUserController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IUnitOfWork _unitOfWork;


        public ServiceUserController(IUnitOfWork unitOfWork, IAccountService accountService)
        {
            _accountService = accountService;
            _unitOfWork = unitOfWork;
        }

        public async Task<ActionResult> Index()
        {
            var allAdmins = await _unitOfWork.Users
                .FindAllAsync(s => s.UserType == UserType.User);

            return View(allAdmins);
        }

        public async Task<ActionResult> WaitForApprove()
        {
            var allAdmins = await _unitOfWork.Users.FindAllAsync(s => (s.UserType == UserType.User) && s.IsApproved == false);

            return View("Index", allAdmins);
        }
        //--------------------------------------------------------------------------------------
        // GET: ServiceUser/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _unitOfWork.Users.FindAsync(
                s => (s.UserType == UserType.User) && s.Id == id,
                include: s => s.Include(user => user.City));
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        //-----------------------------------------------------------------------------------------
        // GET: ServiceUser/EditUser/5
        public async Task<ActionResult> EditUser(string id)
        {
            var user = await _accountService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["Cities"] = new SelectList(await _unitOfWork.Cities.FindAllAsync(s => s.IsDeleted == false && s.IsShow == true), "Id", "NameAr");

            var userModel = new UpdateUserModel()
            {
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Description = user.Description,
                UserId = user.Id,
                CityId = user.CityId ?? 0,
            };


            return View(userModel);
        }

        // POST: ServiceUser/EditUser/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditUser(UpdateUserModel model)
        {
            var User = await _unitOfWork.Users.FindAsync(s => s.UserType == UserType.User && s.Id == model.UserId, isNoTracking: true);
            if (User == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                ViewData["Cities"] = new SelectList(await _unitOfWork.Cities.FindAllAsync(s => s.IsDeleted == false && s.IsShow == true), "Id", "NameAr");
                return View(model);
            }
            var result = await _accountService.UpdateUserProfileAdmin(model.UserId, model);

            if (!result.IsAuthenticated)
            {
                ModelState.AddModelError("", result.ArMessage);
                ViewData["Cities"] = new SelectList(await _unitOfWork.Cities.FindAllAsync(s => s.IsDeleted == false && s.IsShow == true), "Id", "NameAr");
                return View(model);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

        }


        //-----------------------------------------------------------------------------------------
        public async Task<ActionResult> Activate(string id)
        {
            await _accountService.Activate(id);
            TempData["Success"] = "تم تفعيل الحساب بنجاح";
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Suspend(string id)
        {
            await _accountService.Suspend(id);
            TempData["Success"] = "تم إيقاف الحساب بنجاح";
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(string id)
        {
            await _accountService.Delete(id);
            TempData["Success"] = "تم حذف الحساب بنجاح";
            return RedirectToAction("Index");
        }
        //-----------------------------------------------------------------------------------------
        public async Task<ActionResult> Approve(string id)
        {
            await _accountService.Approve(id);
            TempData["Success"] = "تم الموافقة على الحساب بنجاح";
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Reject(string id)
        {
            var result = await _accountService.Reject(id);
            if (result)
            {
                TempData["Success"] = "تم رفض الحساب بنجاح";
            }
            else
            {
                TempData["Error"] = "حدث خطأ أثناء رفض الحساب";
            }
            return RedirectToAction("Index");
        }
        //----------------------------------------------------------------------------------------- Featured
        public async Task<ActionResult> MakeFeatured(string id)
        {
            await _accountService.MakeFeatured(id);
            TempData["Success"] = "تم تعيين الحساب كمميز بنجاح";
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> RemoveFeatured(string id)
        {
            await _accountService.RemoveFeatured(id);
            TempData["Success"] = "تم إزالة الحساب من المميزين بنجاح";
            return RedirectToAction("Index");
        }


    }
}
