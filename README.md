# Enfonica Library for .NET

.NET idiomatic client library for [Enfonica](https://enfonica.com/) services.

## Supported platforms

The library supports the **netstandard2.0** and **net461** target framework monikers.

## Authentication

Define the environment variable `ENFONICA_APPLICATION_CREDENTIALS` to be the location of your service account key file. For example:

```
set ENFONICA_APPLICATION_CREDENTIALS=/path/to/key.json
```

You can obtain a service account key file from the [Enfonica Console](https://console.enfonica.com/).

## Example

```cs
// create client
var client = await new MessagesClientBuilder().BuildAsync();

// send an SMS
var response = await client.CreateMessageAsync(new()
{
    Parent = "projects/my-example-project",
    Message = new()
    {
        To = "+61499888777",
        From = "Enfonica",
        Body = "Hello world!"
    }
});
```