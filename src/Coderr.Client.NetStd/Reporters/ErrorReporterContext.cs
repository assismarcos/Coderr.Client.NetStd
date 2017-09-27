﻿using System;
using System.Collections.Generic;
using codeRR.Client.Contracts;

namespace codeRR.Client.Reporters
{
    /// <summary>
    ///     Context supplied by error reports
    /// </summary>
    /// <remarks>
    ///     Used to be able to provide app specific context information (for instance HTTP apps can provide the HTTP
    ///     context)
    /// </remarks>
    public class ErrorReporterContext : IErrorReporterContext
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ErrorReporterContext" /> class.
        /// </summary>
        /// <param name="reporter">The reporter.</param>
        /// <param name="exception">The exception.</param>
        /// <exception cref="ArgumentNullException">exception</exception>
        public ErrorReporterContext(object reporter, Exception exception)
        {
            Exception = exception ?? throw new ArgumentNullException(nameof(exception));
            Reporter = reporter;
            ContextCollections = new List<ContextCollectionDTO>();
        }

        /// <inheritdoc />
        public IList<ContextCollectionDTO> ContextCollections { get; }

        /// <summary>
        ///     Gets class which is sending the report
        /// </summary>
        /// <remarks>
        /// <para>
        /// 
        /// </para>
        /// </remarks>
        public object Reporter { get; }


        /// <summary>
        ///     Gets caught exception
        /// </summary>
        public Exception Exception { get; }
    }
}