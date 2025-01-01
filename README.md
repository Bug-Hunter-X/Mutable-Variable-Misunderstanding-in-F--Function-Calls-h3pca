# F# Mutable Variable Behavior in Function Calls

This example highlights a potential point of confusion when working with mutable variables and function calls in F#.  The initial values of `x` and `y` are used within the `add` function, and subsequent changes to these variables do not retroactively update the result of the function.