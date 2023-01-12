package com.ataghav.javavsdotnetperformance.rest

import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.bind.annotation.RestController

@RestController
@RequestMapping("/primes")
class PrimeNumbersController {
    @GetMapping("/under-1000")
    fun getPrimesUnder1000(): List<Int> {
        return retainPrimes((1..1000).toList())
    }

    fun retainPrimes(numbers: List<Int>): List<Int> {
        return numbers.filter {
            var isPrime = true
            if (it < 2) {
                isPrime = false
            } else {
//                val uu=(1..it).toList().asSequence()
//                    .any(num-> it%num==0)
                for (i in 2 until it) {
                    if (it % i == 0) {
                        isPrime = false
                        break
                    }
                }
            }
            isPrime
        }
    }
}