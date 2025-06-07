// <copyright file="BitDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BIT data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql?view=sql-server-ver17"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class BitDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class.
    /// </summary>
    public BitDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BitDataType(Source source)
        : base(source)
    {
    }
}