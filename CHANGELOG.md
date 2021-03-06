### Release ?.?.? (future ideas)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.4.1.0...master)
* Finding bip32 key path
* Password recovery
* Multi-thread and SIMD support

### Release 0.4.1 (2020-07-23)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.4.0.0...v0.4.1.0)
* This minor release introduces the Example button in order to simplify the recovery process even more, 
it could be helpful to show how some boxes should be filled in more complex cases such as BIP-32 paths.

### Release 0.4.0 (2020-06-30)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.3.0.0...v0.4.0.0)
* **New feature**: Missing BIP-39 mnomonic words
* Decoupling comparer classes so that they can be injected as dependencies based on user selection
* Optimization of SHA512
* Various code improvements, bug fixes and additional tests

### Release 0.3.0 (2020-05-30)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.2.0.0...v0.3.0.0)
* **New feature**: Missing mini-privatekey characters
* Fix some bugs with missing base-58 cases
* Improve generated reports and the way they are created
* Various code improvements, bug fixes and additional tests

### Release 0.2.0 (2020-05-11)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.1.2.0...v0.2.0.0)
* **New feature**: Missing Base-58 can now find missing chars in addresses
* **New feature**: Missing Base-58 can now find missing chars in BIP-38 encrypted keys
* Various code improvements, bug fixes and additional tests
* Project is now using the well tested [Bitcoin.Net](https://github.com/Autarkysoft/Denovo#bitcoinnet) library as its backend

### Release 0.1.2 (2020-03-10)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.1.1.0...v0.1.2.0)
* **New feature**: missing characters in a base-16 encoded private key
* The missing base58 option can now accepte a full private key and check if it is correct while returning 
useful error message explaining why the given key was invalid.
* Simplify user input in missing base-58 (no checkbox anymore)
* Small code improvements and optimization

### Release 0.1.1 (2020-02-19)
[Full Changelog](https://github.com/Coding-Enthusiast/FinderOuter/compare/v0.1.0.0...v0.1.1.0)
* (GitHub related) Added readme and continous integration using Travis
* Small SHA-256 optimization
* Add some tests
* Various small bug fixes and code improvements
* Add a special case to missing private key chars where a compressed key missing 3 chars
at unknown positions

### [Release 0.1.0 (2020-01-01)](https://github.com/Coding-Enthusiast/FinderOuter/tree/v0.1.0.0)
Initial release for new year with 2 first options:  
1. Missing Base-58 encoded private key characters
2. Message signature verification