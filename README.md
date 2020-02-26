# SOFail
Demonstrates a serious bug with ScriptableObject serialization

Steps to test this out:

- Switch to the branch `no_fields`
- Focus Unity

- Switch to the branch `adding_fields`
- Focus Unity

Note that in the `adding_fields` branch, since the new fields were added to the class (.cs) AND their values were set on a ScriptableObject instance (.asset) in the same commit, the values that were set on the instance were clobbered by the default values from the class. 

This is a pretty bad bug, because once the user changes anything, the clobbered (incorrect) values will now get committed. It happens a LOT for us when working with ScriptableObjects via source control.

The bug occurs with 100% consistency on Unity 2019.1.14f1 - I haven't tried any other versions yet. 
