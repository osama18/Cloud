A fun example of applying system design fundematls on codeing level.

Still needs UI layer to be added so it can be run, build the connection and mappings between layers, and some minor work

What was fund to do in this repo: 
1-Use the strategy pattern for a different implemnetation behaviours for the same components For example : server selection strategy.
2-Abstract the LoadBalancer and provider as they both in the end are servers which will make it easy later to apply more servers concepts like Proxy. This concept also could enable 
multi layers of load balancers (like load balancer distrbutes traffic to some load balancers who distrubutes traffic to application servers).
3-Use similiar concept of decorator pattern to extend the physical servers by thread pool which will act as a different servers.
4-Strived for SOLID principles which would make it easier now to controland monitor  almost all of the operations fromUI when added.
5-User Factories to control instances creations.
6-Used Repositories to move the responsibilites of communicating to storage to data access layer.
