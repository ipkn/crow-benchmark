crow-benchmark
==============

Benchmark codes and results for comparing crow and other frameworks.

go, netty, play benchmarks codes are copied from https://github.com/TechEmpower/FrameworkBenchmarks

Used ["/json" test case](http://www.techempower.com/benchmarks/#section=code&hw=peak&test=json) (simple json response {"message":"Hello, World!"})  
Tested on AWS c3.8xlarge with wrk, 8 core is used for load generating

All numbers in [Benchmark Result](https://docs.google.com/spreadsheets/d/1KidO9XpuwCRZ2p_JRDJj2aep61H8Sh_KDOhApizv4LE/edit?usp=sharing)

Benchmark result in one chart:
![Benchmark Result in one chart](https://docs.google.com/spreadsheets/d/1KidO9XpuwCRZ2p_JRDJj2aep61H8Sh_KDOhApizv4LE/pubchart?oid=2041467789&format=image)

![Benchmark 4096](https://docs.google.com/spreadsheets/d/1KidO9XpuwCRZ2p_JRDJj2aep61H8Sh_KDOhApizv4LE/pubchart?oid=1218829560&format=image)

![Benchmark 16384](https://docs.google.com/spreadsheets/d/1KidO9XpuwCRZ2p_JRDJj2aep61H8Sh_KDOhApizv4LE/pubchart?oid=2019417933&format=image)
