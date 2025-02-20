﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using NUnit.Framework;

namespace Azure.Communication.CallAutomation.Tests.Misc
{
    public class RepeatabilityHeadersTests
    {
        [Test]
        public void RepeatablityHeaders_IsValid_BothHeadersAreNull()
        {
            // arrange
            var headers = new RepeatabilityHeaders();

            // act & assert
            Assert.IsTrue(headers.IsValidRepeatabilityHeaders());
        }

        [Test]
        public void RepeatablityHeaders_IsValid_BothHeadersAreEmpty()
        {
            // arrange
            var headers = new RepeatabilityHeaders {
                RepeatabilityRequestId = Guid.Empty,
                RepeatabilityFirstSent = ""
            };

            // act & assert
            Assert.IsTrue(headers.IsValidRepeatabilityHeaders());
        }

        [Test]
        public void RepeatablityHeaders_IsValid_BothHeadersAreSet()
        {
            // arrange
            var headers = new RepeatabilityHeaders
            {
                RepeatabilityRequestId = Guid.NewGuid(),
                RepeatabilityFirstSent = DateTimeOffset.Now.ToString("R")
            };

            // act & assert
            Assert.IsTrue(headers.IsValidRepeatabilityHeaders());
        }

        [Test]
        public void RepeatablityHeaders_IsInvalid_RequestIdIsEmptyAndFirstSentIsNot()
        {
            // arrange
            var headers = new RepeatabilityHeaders
            {
                RepeatabilityRequestId = Guid.Empty,
                RepeatabilityFirstSent = DateTimeOffset.Now.ToString("R")
        };

            // act & assert
            Assert.IsFalse(headers.IsValidRepeatabilityHeaders());
        }

        [Test]
        public void RepeatablityHeaders_IsInvalid_RequestIdIsSetAndFirstSentIsNot()
        {
            // arrange
            var headers = new RepeatabilityHeaders
            {
                RepeatabilityRequestId = Guid.NewGuid()
            };

            // act & assert
            Assert.IsFalse(headers.IsValidRepeatabilityHeaders());
        }

        [Test]
        public void RepeatablityHeaders_IsInvalid_FirstSentIsSetAndRequestIdIsNot()
        {
            // arrange
            var headers = new RepeatabilityHeaders
            {
                RepeatabilityFirstSent = DateTimeOffset.Now.ToString("R")
            };

            // act & assert
            Assert.IsFalse(headers.IsValidRepeatabilityHeaders());
        }
    }
}
