# basic-vnext-benchmark


These are some basic benchmarks I did for my blog post "[MVC vs Middleware Performance in ASP.NET 5](http://blog.asm.io/asp-5-middleware-performance)"

If you'd like to run them:
* [Install DNVM](https://docs.asp.net/en/latest/getting-started/installing-on-mac.html)
* [Install Visual Studio Code](https://code.visualstudio.com)
* Install `wrk`: `brew install wrk`
* Open either solution, do ⌘⇧p and select the "dnx web" option
* Once the solution builds and runs, run `wrk -c 50 -t 25 -d 1m http://localhost:5000`
