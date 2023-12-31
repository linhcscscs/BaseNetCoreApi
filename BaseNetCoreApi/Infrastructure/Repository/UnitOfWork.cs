﻿using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BaseNetCoreApi.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IPhoCapGDContextProvider _contextProvider;
        private IWorkContextService _workContextService;

        private int ma_nam_hoc;
        public UnitOfWork(IPhoCapGDContextProvider contextProvider, IWorkContextService workContextService)
        {
            _contextProvider = contextProvider;
            _workContextService = workContextService;

            ma_nam_hoc = workContextService.MA_NAM_HOC;
        }

        public void SetNamHoc(int maNamHoc)
        {
            ma_nam_hoc = maNamHoc;
        }

        public int NamHoc
        {
            get => ma_nam_hoc;
        }

        public PHO_CAP_GDEntities ReadContext
        {
            get => _contextProvider.GetRead(ma_nam_hoc);
        }

        public PHO_CAP_GDEntities WriteContext
        {
            get => _contextProvider.GetWrite(ma_nam_hoc);
        }

        public IQueryable<T>SqlQuery<T>(FormattableString sqlQuery, bool isWrite = false)
        {
            var context = isWrite ? WriteContext : ReadContext;
            return context.Database.SqlQuery<T>(sqlQuery);
        }
        public IQueryable<T> SqlQuery<T>(string sqlQuery, bool isWrite = false)
        {
            var context = isWrite ? WriteContext : ReadContext;
            return context.Database.SqlQueryRaw<T>(sqlQuery);
        }
        public int ExcuteSqlCommand(string sqlCommand)
        {
             return WriteContext.Database.ExecuteSqlRaw(sqlCommand);
        }

        public void SaveChanges()
        {
            WriteContext.BulkSaveChanges();
        }

        public void BulkSaveChanges(BulkConfig bulkConfig)
        {
            WriteContext.BulkSaveChanges(bulkConfig);
        }
    }
}
