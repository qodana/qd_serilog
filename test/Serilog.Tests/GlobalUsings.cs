﻿global using System.Collections;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Reflection;
global using System.Reflection.Emit;
global using System.Text;
global using System.Text.RegularExpressions;
global using Serilog.Capturing;
global using Serilog.Configuration;
global using Serilog.Context;
global using Serilog.Core;
global using Serilog.Core.Enrichers;
global using Serilog.Core.Filters;
global using Serilog.Core.Pipeline;
global using Serilog.Core.Sinks;
global using Serilog.Data;
global using Serilog.Debugging;
global using Serilog.Events;
global using Serilog.Filters;
global using Serilog.Formatting;
global using Serilog.Formatting.Display;
global using Serilog.Formatting.Json;
global using Serilog.Parsing;
global using Serilog.Rendering;
global using Serilog.Settings.KeyValuePairs;
global using Serilog.Tests.Support;
global using TestDummies;
global using TestDummies.Console;
global using TestDummies.Console.Themes;
global using Xunit;
global using Xunit.Sdk;
global using static Serilog.Events.LogEventLevel;

#if REMOTING
global using System.Runtime.Remoting;
global using System.Runtime.Remoting.Lifetime;
global using System.Runtime.Remoting.Messaging;
global using System.Runtime.Remoting.Services;
#endif
