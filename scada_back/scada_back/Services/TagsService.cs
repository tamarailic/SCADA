﻿using System;
using MongoDB.Driver;
using scada_back.Models;

namespace scada_back.Services
{
    public class TagsService
    {
        private MongoDBService _mongo;
        public TagsService(MongoDBService mongoDB)
        {
            _mongo = mongoDB;
        }

        public async Task<List<AnalogInput>> GetAllAnalogInputsAsync()
        {
            return await _mongo._analogInputsCollection.Find(_ => true).ToListAsync();

        }
    }
}
