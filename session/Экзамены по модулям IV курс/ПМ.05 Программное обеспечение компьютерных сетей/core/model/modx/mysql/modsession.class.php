<?php
/*
 * This file is part of MODX Revolution.
 *
 * Copyright (c) MODX, LLC. All Rights Reserved.
 *
 * For complete copyright and license information, see the COPYRIGHT and LICENSE
 * files found in the top-level directory of this distribution.
 */

include_once (strtr(realpath(dirname(__FILE__)), '\\', '/') . '/../modsession.class.php');
/**
 * @package modx
 * @subpackage mysql
 */
class modSession_mysql extends modSession {}
