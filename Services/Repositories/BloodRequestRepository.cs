using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace DonateBlood.Services.Repositories
{
    public class BloodRequestRepository : Repository<BloodRequest>, IBloodRequestRepository
    {

        private  AplicationDbContext _context;

        public BloodRequestRepository(AplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void addBloodRequest(BloodRequest model)
        {
            _context.BloodRequests.Add(model);
        }

        public BloodRequestShowModel getBloodRequestById(int Id)
        {

            var bloodrequest = _context.BloodRequests.Where(i => i.Id == Id).Include(i => i.User).Select(i => new BloodRequestShowModel
            {
                Id = i.Id,
                ProfileImg = i.User.ProfileImg,
                DonateLocation = i.DonateLocation,
                BloodReqDesc = i.BloodReqDesc,
                BloodType = i.BloodType,
                AplicationUserId = i.User.Id
            }).FirstOrDefault();

            return bloodrequest;

        }

        public ICollection<BloodRequestShowModel> getBloodRequests()
        {
            var bloodrequest = _context.BloodRequests.Include(i => i.User).Select(i => new BloodRequestShowModel
            {
                Id = i.Id,
                ProfileImg = i.User.ProfileImg,
                DonateLocation = i.DonateLocation,
                BloodReqDesc = i.BloodReqDesc,
                BloodType = i.BloodType,
                AplicationUserId = i.User.Id

            }).ToList();
            return bloodrequest;

        }
    }

}