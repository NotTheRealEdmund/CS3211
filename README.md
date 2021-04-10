# CS3211

Course project for CS3211 - Parallel and Concurrent Programming

Two options were given to the students.<br>
P1: Formal Verification of TLS 1.3 (Key Exchange) Protocol<br>
P2: Applying Probabilistic Model Checking in Soccer Analytics<br>

This github repo contains the code for option P2.<br>
Apply Probabilistic Model Checking technique to model a soccer game with multiple parallel processes and reason the relations between player strategy and the team’s winning chance.

Project requirement:<br>
● Use CSP# (PAT) to model and verify system properties.<br>
● Use CSP# (PAT) concurrent construct to model the concurrent behaviors.<br>
● The main deliverable is a project report, which is about 20 pages (single spaced 11/12pt) and contains the following:<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Describe the application you have chosen to model.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Properties to be verified, e.g. reachability probabilities.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Formal model in CSP# language.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Result and discussion.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Feedback on how to improve the PAT.<br>

# PAT
PAT is a self-contained framework for to support composing, simulating and reasoning of concurrent, real-time systems and other possible domains. It comes with user friendly interfaces, featured model editor and animated simulator. Most importantly, PAT implements various model checking techniques catering for different properties such as deadlock-freeness, divergence-freeness, reachability, LTL properties with fairness assumptions, refinement checking and probabilistic model checking. To achieve good performance, advanced optimization techniques are implemented in PAT, e.g. partial order reduction, symmetry reduction, process counter abstraction, parallel model checking. So far, PAT has 4370+ registered users from 1341+ organizations in 150 countries and regions.
