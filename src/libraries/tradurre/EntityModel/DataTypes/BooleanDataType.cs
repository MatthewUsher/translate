// <copyright file="BooleanDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BOOLEAN (1 byte) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-99 standard as BOOLEAN.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-boolean.html" />
/// </remarks>
public sealed class BooleanDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanDataType"/> class.
    /// </summary>
    public BooleanDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BooleanDataType(Source source)
        : base(source)
    {
    }
}