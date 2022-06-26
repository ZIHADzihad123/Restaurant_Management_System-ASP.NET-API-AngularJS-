using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableService
    {
        static TableService()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<TableModel, Table>();
                cfg.CreateMap<Table, TableModel>();
                
            });
        }

        public static List<TableModel> GetTable()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Table, TableModel>());
            //AutoMapper.Mapper
            var data = Mapper.Map<List<TableModel>>(DataAccessFactory.TableDataAccess().GetAllTable()); // for automapper 6.1.1
            //var data = Mapper.Map<List<TableModel>>(TableRepo.GetAllTable());
            return data;
        }

        public static List<TableModel> GetReserved()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Table, TableModel>());
            //AutoMapper.Mapper
            var data = Mapper.Map<List<TableModel>>(DataAccessFactory.TableDataAccess().GetReservedTable()); // for automapper 6.1.1
            return data;
        }

        public static List<TableModel> GetNonReserved()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Table, TableModel>());
            //AutoMapper.Mapper
            var data = Mapper.Map<List<TableModel>>(DataAccessFactory.TableDataAccess().GetNonReservedTable()); // for automapper 6.1.1
            return data;
        }

        public static void TableReserve(TableModel tl)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TableModel, Table>());
            //AutoMapper.Mapper
            var data = Mapper.Map<Table>(tl);
            //var data = tl;
            DataAccessFactory.TableDataAccess().TableReserve(data); // for automapper 6.1.1
            
        }
    }
}
