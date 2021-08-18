﻿namespace CSharpIntermediate.Models
{
    public class Migrator
    {
        private readonly Logger _logger;

        public Migrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are in the migrator file");
        }
    }
}
