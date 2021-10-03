using System;

namespace CSharpCourse.Core.Lib.Models
{
    public interface IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Identifier of entity
        /// </summary>
        TKey Id { get; set; }
    }

    public class IdModel<TKey> : IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <inheritdoc cref="IIdModel{TKey}"/>
        public TKey Id { get; set; }
    }
}