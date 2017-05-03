// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     <para>
    ///         An API for getting logger categories inan Intellisense/tab-completion friedly manner.
    ///     </para>
    ///     <para>
    ///         Get an Entity Framework Core logger category using its Name property. For example,
    ///         <code>LoggerCategory.Database.Sql.Name</code>.
    ///     </para>
    ///     <para>
    ///         Use these types with <see cref="IDiagnosticsLogger{TLoggerCategory}" /> or
    ///         <see cref="IDiagnosticsLogger{TLoggerCategory}" /> to create a logger.
    ///     </para>
    /// </summary>
    public static class LoggerCategory
    {
        /// <summary>
        ///     The root/prefix for all Entity Framework categories.
        /// </summary>
        public const string Root = "Microsoft.EntityFrameworkCore";

        /// <summary>
        ///     Logger categories for messages related to database interactions.
        /// </summary>
        public class Database : LoggerCategory<Database>
        {
            /// <summary>
            ///     Logger category for messages related to connection operations.
            /// </summary>
            public class Connection : LoggerCategory<Connection>
            {
            }

            /// <summary>
            ///     Logger category for messages related to data reader operations.
            /// </summary>
            public class DataReader : LoggerCategory<DataReader>
            {
            }

            /// <summary>
            ///     Logger category for SQL sent to the database.
            /// </summary>
            public class Sql : LoggerCategory<Sql>
            {
            }

            /// <summary>
            ///     Logger category for messages related to transaction operations.
            /// </summary>
            public class Transaction : LoggerCategory<Transaction>
            {
            }
        }

        /// <summary>
        ///     Logger category for messages related to <see cref="DbContext.SaveChanges()" />, excluding
        ///     messages specifically relating to database interactions which are covered by
        ///     the <see cref="LoggerCategory.Database" /> categories.
        /// </summary>
        public class Update : LoggerCategory<Update>
        {
        }

        /// <summary>
        ///     Logger categories for messages related to model building and metadata.
        /// </summary>
        public class Model : LoggerCategory<Model>
        {
            /// <summary>
            ///     Logger category for messages from model validation.
            /// </summary>
            public class Validation : LoggerCategory<Validation>
            {
            }
        }

        /// <summary>
        ///     Logger category for messages related to queries, excluding
        ///     the generated SQL, which is in the <see cref="LoggerCategory.Database.Sql" /> category.
        /// </summary>
        public class Query : LoggerCategory<Query>
        {
        }

        /// <summary>
        ///     Logger category for miscellaneous messages from the Entity Framework infrastructure.
        /// </summary>
        public class Infrastructure : LoggerCategory<Infrastructure>
        {
        }

        /// <summary>
        ///     Logger category for messages from scaffolding/reverse engineering.
        /// </summary>
        public class Scaffolding : LoggerCategory<Scaffolding>
        {
        }

        /// <summary>
        ///     Logger category messages from Migrations.
        /// </summary>
        public class Migrations : LoggerCategory<Migrations>
        {
        }
    }
}
