using Singleton.Logger;

// Invoked methods parallely to verify thread safety.
Parallel.Invoke(WriteInfo, WriteError);
Parallel.Invoke(WriteInfoEager, WriteErrorEager);
Parallel.Invoke(WriteInfoLazy, WriteErrorLazy);

static void WriteInfo()
{
    Logger logger = Logger.GetInstance;
    logger.LogInformation("Success.");
}

static void WriteError()
{
    Logger logger = Logger.GetInstance;
    logger.LogError("Error.");
}

static void WriteInfoEager()
{
    EagerLogger logger = EagerLogger.GetInstance;
    logger.LogInformation("Eager Loading Success.");
}

static void WriteErrorEager()
{
    EagerLogger logger = EagerLogger.GetInstance;
    logger.LogError("Eager Loading Error.");
}

static void WriteInfoLazy()
{
    LazyLogger logger = LazyLogger.GetInstance;
    logger.LogInformation("Lazy Loading Success.");
}

static void WriteErrorLazy()
{
    LazyLogger logger = LazyLogger.GetInstance;
    logger.LogError("Lazy Loading Error.");
}
