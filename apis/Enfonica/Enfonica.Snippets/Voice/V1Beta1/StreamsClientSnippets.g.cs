// Copyright 2021 Enfonica Pty Ltd
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Enfonica.Voice.V1Beta1.Snippets
{
    using Google.Api.Gax.Grpc;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedStreamsClientSnippets
    {
        /// <summary>Snippet for StreamCall</summary>
        public async Task StreamCall()
        {
            // Snippet: StreamCall(CallSettings, BidirectionalStreamingSettings)
            // Create client
            StreamsClient streamsClient = StreamsClient.Create();
            // Initialize streaming call, retrieving the stream object
            StreamsClient.StreamCallStream response = streamsClient.StreamCall();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamCallResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamCallResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamCallRequest request = new StreamCallRequest
                {
                    Setup = new StreamSetup(),
                    InputAudio = new InputAudio(),
                    UpdateRequestParameters = new UpdateRequestParameters(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
