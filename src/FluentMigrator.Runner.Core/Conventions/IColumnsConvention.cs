#region License
// Copyright (c) 2007-2024, Fluent Migrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using FluentMigrator.Expressions;

namespace FluentMigrator.Runner.Conventions
{
    /// <summary>
    /// A convention working on <see cref="IColumnsExpression"/> implementations
    /// </summary>
    public interface IColumnsConvention
    {
        /// <summary>
        /// Applies a convention to a <see cref="IColumnsExpression"/>
        /// </summary>
        /// <param name="expression">The expression this convention should be applied to</param>
        /// <returns>The same or a new expression. The underlying type must stay the same.</returns>
        IColumnsExpression Apply(IColumnsExpression expression);
    }
}
