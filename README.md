Modified from [upstream](https://github.com/MachaCeleste/AltStreamLib):
- Uses `net472` *(for better Unity modding support)*
- Drops use of `System.Net.Http.Json` in `HttpManager` for `Newtonsoft.Json` *(for better Unity modding support)*
- Adds a public `OnLog` action in the `EventSubClient` class
- Allows anonymous API calls (per API docs)

------

Depends on [SseClientLib](https://git.gay/TheBlackParrot/SseClientLib-net472)
