namespace SerializableExceptionGenerator
{
    [Flags]
    internal enum GenerateTarget
    {
        None = 0,
        DefaultConstructor = 1,
        StringMessageConstructor = 1 << 1,
        StringMessageExceptionConstructor = 1 << 2,
        SerializationInfoStreamingContextConstructor = 1 << 3,
        All =
            DefaultConstructor
            | StringMessageConstructor
            | StringMessageExceptionConstructor
            | SerializationInfoStreamingContextConstructor
    }
}
