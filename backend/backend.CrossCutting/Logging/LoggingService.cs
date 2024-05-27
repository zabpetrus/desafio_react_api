using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.CrossCutting.Logging
{
    public class LoggingService
    {
        private readonly ILogger<LoggingService> _logger;

        public LoggingService(ILogger<LoggingService> logger)
        {
            _logger = logger;
        }



        public void setMessage(string message)
        {
            _logger.LogInformation(message);
        }

        public void setErrorMessage(string message)
        {
            _logger.LogError(message);
        }
    }
}
