﻿using System;
using System.Collections.Generic;
using GitHub;
using GitHub.Internals;
using NSubstitute;
using NSubstitute.Core;

public static class TestHelper
{
    public static IEnumerable<Result<T, T>> Results<T>() => Results<T, T>();
    public static IEnumerable<Result<T, TClean>> Results<T, TClean>() => ((InMemoryResultPublisher)Scientist.ResultPublisher).Results<T, TClean>();

    public static ConfiguredCall Throws<T>(this T value, Exception e) => value.Returns(_ => { throw e; });
}
