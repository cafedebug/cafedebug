﻿using System;
using System.Collections.Generic;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using log4net;

namespace Cafedebug.Business.Services
{
    public class EpisodioService : BaseService, IEpisodioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodioService));

        public Lazy<IEpisodioRepository> EpisodioRepository { get; set; }

        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }

        public EpisodioService(INotificador notificador) : base(notificador)
        {

        }

        public void Save(Episodio episodio)
        {
            try
            {
                EpisodioRepository.Value.Save(episodio);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao salvar um episódio", ex.Message, episodio);
                throw;
            }
        }

        public void Update(int id)
        {
            try
            {
                EpisodioRepository.Value.Update(id);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao atualizar um episódio", ex.Message, id);
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Episodio> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ExcluiUsuarioExistenteNaBase(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
