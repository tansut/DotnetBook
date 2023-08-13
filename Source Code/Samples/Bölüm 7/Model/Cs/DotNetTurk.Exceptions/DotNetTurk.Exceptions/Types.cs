using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DotNetTurk.Exceptions
{

    [global::System.Serializable]
    public class UserException : ApplicationException
    {
        public UserException()
        {
        }
        public UserException(string message) : base(message)
        {
        }
        public UserException(string message, Exception inner) : base(message, inner)
        {
        }
        protected UserException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }


    [global::System.Serializable]
    public class TechnicalException : ApplicationException
    {
        public TechnicalException()
        {
        }
        public TechnicalException(string message) : base(message)
        {
        }
        public TechnicalException(string message, Exception inner) : base(message, inner)
        {
        }
        protected TechnicalException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }


    [global::System.Serializable]
    public class ApplicationSecurityException : UserException
    {
        public ApplicationSecurityException()
        {
        }
        public ApplicationSecurityException(string message) : base(message)
        {
        }
        public ApplicationSecurityException(string message, Exception inner) : base(message, inner)
        {
        }
        protected ApplicationSecurityException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }

    public interface IExceptionPublisher
    {
        void Publish(Exception exc);
    }

    public interface IExceptionFilter
    {
        bool Filter(Exception exc);
    }

    
    public sealed class ExceptionManager
    {
        private static IExceptionPublisher publisher;
        private static IExceptionFilter filter;

        static ExceptionManager()
        {
            Type type = Type.GetType(ConfigurationManager.AppSettings["ExceptionPublisher"], true);
            publisher = (IExceptionPublisher)Activator.CreateInstance(type);

            type = Type.GetType(ConfigurationManager.AppSettings["ExceptionFilter"], true);
            filter = (IExceptionFilter)Activator.CreateInstance(type);
        }

        public static void Publish(Exception exc)
        {
            if (filter.Filter(exc))
                publisher.Publish(exc);
        }

        public static ApplicationException Convert(Exception exc)
        {
            if (exc is UserException)
                return (UserException)exc;
            else if (exc is TechnicalException)
                return (TechnicalException)exc;
            else
                return new TechnicalException("Sistemde teknik hata oluştu.", exc);
        }

        private ExceptionManager()
        {
        }
    }
}
