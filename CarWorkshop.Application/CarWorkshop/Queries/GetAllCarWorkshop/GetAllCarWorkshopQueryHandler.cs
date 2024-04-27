using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using CarWorkshop.Domain.Inferfaces;

using MediatR;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetAllCarWorkshop
{ 
    public class GetAllCarWorkshopQueryHandler : IRequestHandler<GetAllCarWorkshopQuery, IEnumerable<CarWorkshopDto>>
    {
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        private readonly IMapper _mapper;

        public GetAllCarWorkshopQueryHandler(ICarWorkshopRepository carWorkshopRepository, IMapper mapper)
        {
            _carWorkshopRepository = carWorkshopRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CarWorkshopDto>> Handle(GetAllCarWorkshopQuery request, CancellationToken cancellationToken)
        {
           
                var carWorkshops = await _carWorkshopRepository.GetAll();
                var dtos = _mapper.Map<IEnumerable<CarWorkshopDto>>(carWorkshops);

                return dtos;
            
        }
    }
}
