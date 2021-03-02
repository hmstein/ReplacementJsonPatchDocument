# ReplacementJsonPatchDocument

An extension method made for the JsonPatchDocument class to generate 'replace' commands for the entire input object.

I needed to generate a JsonPatchDocument based on a client side object that contained only part of the data for the API's PATCH endpoint.

(A PUT would have been preferred, but the front end only had access to some data, so we needed to do a sort of "Idempotent PATCH")
