This repository demonstrates a common pitfall in F# related to mutable variables and pass-by-reference/value.  The `bug.fs` file shows code that unexpectedly modifies variables due to pass-by-reference, while `bugSolution.fs` provides a corrected version that avoids unintended side effects.  Understanding this difference is crucial for writing correct and predictable F# code.