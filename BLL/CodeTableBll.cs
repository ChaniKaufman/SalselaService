using AutoMapper;
using DAL;
using DAL.Classes;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CodeTableBll:ICodeTableBll
    {
        ICodeTableDal _ICodeTableDal;
        IMapper _imapper;

        public CodeTableBll(ICodeTableDal CodeTableDal)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _ICodeTableDal = CodeTableDal;
        }

        public List<CodeTableDto> GetAuthorizationTypes()
        {
            List<CodeTable> c = _ICodeTableDal.GetAuthorizationTypes();

            return _imapper.Map<List<CodeTable>, List<CodeTableDto>>(c);
        }


    }
}
