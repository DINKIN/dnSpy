﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.Debugger.Attach;
using dnSpy.Contracts.Debugger.StartDebugging.Dialog;

namespace dnSpy.Contracts.Debugger {
	/// <summary>
	/// Base class of options required to start debugging a program. Created eg. by <see cref="StartDebuggingOptionsPage.GetOptions"/>
	/// and <see cref="AttachProgramOptions.GetOptions"/>. The options are then passed to <see cref="DbgManager.Start(StartDebuggingOptions)"/>.
	/// </summary>
	public abstract class StartDebuggingOptions {
		/// <summary>
		/// Clones this instance
		/// </summary>
		/// <returns></returns>
		public abstract StartDebuggingOptions Clone();
	}
}
