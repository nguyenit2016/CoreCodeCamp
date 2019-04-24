using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>();
            //Khi can thay doi fieldName thi map lai cho fieldName do. vd: FieldName: Venue
            //this.CreateMap<Camp, CampModel>().ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName));
        }
    }
}
