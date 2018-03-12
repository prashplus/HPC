Pre-requisites
--------------

1. Client machine: XP, Vista, 7 or 8 with the following software installed:
    - Microsoft HPC Pack 2012 Client Utilities
    - Microsoft HPC Pack 2012 SDK
    - Visual Studio 2010 or later


2. Server machine: Windows HPC Server 2012

Steps
-----

1. Open RealTimeMode.sln with visual studio.

2. Open Program.cs and change headnode setting

3. Build project Service and deploy the service
	a. Open RealTimeMode\PrimeFactorizationService\bin
	b. Copy PrimeFactorizationService.dll to a share folder which can be accessed by all compute nodes.
	c. Open PrimeFactorizationService.config and change assembly path to your share folder
	d. Copy PrimeFactorizationService.config to %CCP_HOME%ServiceRegistration/ on head node

4. Set Client as startup project and run it multiple times.
